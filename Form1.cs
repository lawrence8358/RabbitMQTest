using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RabbitMQTest
{
    public partial class Form1 : Form
    {
        IConnection connection;
        IModel channel;

        public Form1()
        {
            InitializeComponent();
            this.Input_Connection.Text = Properties.Settings.Default.RabbitMQUrl;
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 請先登入取得連線字串
            // https://customer.cloudamqp.com/
            this.ChangeButtonStatus();
        }

        private void Button_OpenConn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.connection != null) return;

                var factory = new ConnectionFactory();
                factory.Uri = new Uri(this.Input_Connection.Text);

                this.connection = factory.CreateConnection();
                this.ChangeButtonStatus();

                Properties.Settings.Default.RabbitMQUrl = this.Input_Connection.Text;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("連線發生錯誤 :: " + ex.Message);
            }
        }

        private void Button_CloseConn_Click(object sender, EventArgs e)
        {
            if (this.connection == null) return;

            if (this.channel != null)
            {
                this.channel.Close();
                this.channel = null;
            }

            this.connection.Close();
            this.connection = null;

            this.ChangeButtonStatus();
        }

        private void Button_CreateChannel_Click(object sender, EventArgs e)
        {
            this.channel = connection.CreateModel();

            this.ChangeButtonStatus();
        }

        private void Button_CloseChannel_Click(object sender, EventArgs e)
        {
            if (this.channel == null) return;

            this.channel.Close();
            this.channel = null;

            this.ChangeButtonStatus();
        }

        private void Button_CreateExchange_Click(object sender, EventArgs e)
        {
            channel.ExchangeDeclare(exchange: this.Input_Exchange.Text, type: ExchangeType.Fanout, true);
            this.ChangeButtonStatus();
        }

        private void Button_DeleteExchange_Click(object sender, EventArgs e)
        {
            channel.ExchangeDelete(exchange: this.Input_Exchange.Text);
            this.ChangeButtonStatus();
        }

        private void Button_CreateQueue_Click(object sender, EventArgs e)
        {
            channel.QueueDeclare(this.Input_Queue.Text, true);
            channel.QueueBind(this.Input_Queue.Text, this.Input_Exchange.Text, this.Input_RouteKey.Text);
            this.ChangeButtonStatus();
        }

        private void Button_DeleteQueue_Click(object sender, EventArgs e)
        {
            channel.QueueUnbind(this.Input_Queue.Text, this.Input_Exchange.Text, this.Input_RouteKey.Text);
            channel.QueueDelete(this.Input_Queue.Text);
            this.ChangeButtonStatus();
        }

        private void Button_PublishMessage_Click(object sender, EventArgs e)
        {
            try
            {
                this.Button_PublishMessage.Enabled = false;
                var body = $"{ DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") } : { this.Input_PublishMessage.Text }";
                channel.BasicPublish(exchange: this.Input_PublishExchange.Text,
                                     routingKey: this.Input_PublishRouteKey.Text,
                                     basicProperties: null,
                                     body: Encoding.UTF8.GetBytes(body));

                this.Label_PublishSend.Text = $"Send -> { body }";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
            finally
            {
                this.ChangeButtonStatus();
            }
        }

        private void Button_SubscribeMessage_Click(object sender, EventArgs e)
        {
            try
            {
                this.Button_SubscribeMessage.Enabled = false;
                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    this.Label_SubscribeResult.Text = $"Result -> { message }";
                };
                channel.BasicConsume(queue: this.Input_SubscribeQueue.Text,
                                     autoAck: true,
                                     consumer: consumer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
            finally
            {
                this.ChangeButtonStatus();
            }
        }

        private void ChangeButtonStatus()
        {
            var isConn = this.connection != null;
            var isChannel = this.channel != null;
            this.Button_OpenConn.Enabled = !isConn;
            this.Button_CloseConn.Enabled = isConn;

            if (!isConn)
            {
                this.Button_CreateChannel.Enabled = false;
                this.Button_CloseChannel.Enabled = false;
                this.Button_CreateExchange.Enabled = false;
                this.Button_DeleteExchange.Enabled = false;
                this.Button_CreateQueue.Enabled = false;
                this.Button_DeleteQueue.Enabled = false;
                this.Button_PublishMessage.Enabled = false;
                this.Button_SubscribeMessage.Enabled = false;
            }
            else
            {
                this.Button_CreateChannel.Enabled = !isChannel;
                this.Button_CloseChannel.Enabled = isChannel;
                this.Button_CreateExchange.Enabled = isChannel;
                this.Button_DeleteExchange.Enabled = isChannel;
                this.Button_CreateQueue.Enabled = isChannel;
                this.Button_DeleteQueue.Enabled = isChannel;
                this.Button_PublishMessage.Enabled = isChannel;
                this.Button_SubscribeMessage.Enabled = isChannel;
            }
        }
    }
}
