namespace RabbitMQTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_CloseConn = new System.Windows.Forms.Button();
            this.Button_OpenConn = new System.Windows.Forms.Button();
            this.Input_Connection = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button_CloseChannel = new System.Windows.Forms.Button();
            this.Button_CreateChannel = new System.Windows.Forms.Button();
            this.Input_Exchange = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Button_DeleteExchange = new System.Windows.Forms.Button();
            this.Button_CreateExchange = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Input_RouteKey = new System.Windows.Forms.TextBox();
            this.Button_DeleteQueue = new System.Windows.Forms.Button();
            this.Button_CreateQueue = new System.Windows.Forms.Button();
            this.Input_Queue = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Label_PublishSend = new System.Windows.Forms.Label();
            this.Input_PublishMessage = new System.Windows.Forms.TextBox();
            this.Input_PublishRouteKey = new System.Windows.Forms.TextBox();
            this.Button_PublishMessage = new System.Windows.Forms.Button();
            this.Input_PublishExchange = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Label_SubscribeResult = new System.Windows.Forms.Label();
            this.Button_SubscribeMessage = new System.Windows.Forms.Button();
            this.Input_SubscribeQueue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_CloseConn);
            this.groupBox1.Controls.Add(this.Button_OpenConn);
            this.groupBox1.Controls.Add(this.Input_Connection);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Size = new System.Drawing.Size(395, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // Button_CloseConn
            // 
            this.Button_CloseConn.Location = new System.Drawing.Point(312, 29);
            this.Button_CloseConn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_CloseConn.Name = "Button_CloseConn";
            this.Button_CloseConn.Size = new System.Drawing.Size(75, 24);
            this.Button_CloseConn.TabIndex = 2;
            this.Button_CloseConn.Text = "Close";
            this.Button_CloseConn.UseVisualStyleBackColor = true;
            this.Button_CloseConn.Click += new System.EventHandler(this.Button_CloseConn_Click);
            // 
            // Button_OpenConn
            // 
            this.Button_OpenConn.Location = new System.Drawing.Point(234, 29);
            this.Button_OpenConn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_OpenConn.Name = "Button_OpenConn";
            this.Button_OpenConn.Size = new System.Drawing.Size(75, 24);
            this.Button_OpenConn.TabIndex = 1;
            this.Button_OpenConn.Text = "Open";
            this.Button_OpenConn.UseVisualStyleBackColor = true;
            this.Button_OpenConn.Click += new System.EventHandler(this.Button_OpenConn_Click);
            // 
            // Input_Connection
            // 
            this.Input_Connection.Location = new System.Drawing.Point(8, 29);
            this.Input_Connection.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Input_Connection.Name = "Input_Connection";
            this.Input_Connection.Size = new System.Drawing.Size(220, 22);
            this.Input_Connection.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button_CloseChannel);
            this.groupBox2.Controls.Add(this.Button_CreateChannel);
            this.groupBox2.Location = new System.Drawing.Point(6, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox2.Size = new System.Drawing.Size(395, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Channel";
            // 
            // Button_CloseChannel
            // 
            this.Button_CloseChannel.Location = new System.Drawing.Point(102, 23);
            this.Button_CloseChannel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_CloseChannel.Name = "Button_CloseChannel";
            this.Button_CloseChannel.Size = new System.Drawing.Size(86, 24);
            this.Button_CloseChannel.TabIndex = 3;
            this.Button_CloseChannel.Text = "Close Channel";
            this.Button_CloseChannel.UseVisualStyleBackColor = true;
            this.Button_CloseChannel.Click += new System.EventHandler(this.Button_CloseChannel_Click);
            // 
            // Button_CreateChannel
            // 
            this.Button_CreateChannel.Location = new System.Drawing.Point(8, 23);
            this.Button_CreateChannel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_CreateChannel.Name = "Button_CreateChannel";
            this.Button_CreateChannel.Size = new System.Drawing.Size(86, 24);
            this.Button_CreateChannel.TabIndex = 2;
            this.Button_CreateChannel.Text = "Create Channel";
            this.Button_CreateChannel.UseVisualStyleBackColor = true;
            this.Button_CreateChannel.Click += new System.EventHandler(this.Button_CreateChannel_Click);
            // 
            // Input_Exchange
            // 
            this.Input_Exchange.Location = new System.Drawing.Point(4, 29);
            this.Input_Exchange.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Input_Exchange.Name = "Input_Exchange";
            this.Input_Exchange.Size = new System.Drawing.Size(166, 22);
            this.Input_Exchange.TabIndex = 1;
            this.Input_Exchange.Text = "MyExchange";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Button_DeleteExchange);
            this.groupBox3.Controls.Add(this.Button_CreateExchange);
            this.groupBox3.Controls.Add(this.Input_Exchange);
            this.groupBox3.Location = new System.Drawing.Point(6, 148);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox3.Size = new System.Drawing.Size(395, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exchange";
            // 
            // Button_DeleteExchange
            // 
            this.Button_DeleteExchange.Location = new System.Drawing.Point(265, 29);
            this.Button_DeleteExchange.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_DeleteExchange.Name = "Button_DeleteExchange";
            this.Button_DeleteExchange.Size = new System.Drawing.Size(86, 22);
            this.Button_DeleteExchange.TabIndex = 4;
            this.Button_DeleteExchange.Text = "Delete Exchange";
            this.Button_DeleteExchange.UseVisualStyleBackColor = true;
            this.Button_DeleteExchange.Click += new System.EventHandler(this.Button_DeleteExchange_Click);
            // 
            // Button_CreateExchange
            // 
            this.Button_CreateExchange.Location = new System.Drawing.Point(176, 29);
            this.Button_CreateExchange.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_CreateExchange.Name = "Button_CreateExchange";
            this.Button_CreateExchange.Size = new System.Drawing.Size(86, 22);
            this.Button_CreateExchange.TabIndex = 3;
            this.Button_CreateExchange.Text = "Create Exchange";
            this.Button_CreateExchange.UseVisualStyleBackColor = true;
            this.Button_CreateExchange.Click += new System.EventHandler(this.Button_CreateExchange_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Input_RouteKey);
            this.groupBox4.Controls.Add(this.Button_DeleteQueue);
            this.groupBox4.Controls.Add(this.Button_CreateQueue);
            this.groupBox4.Controls.Add(this.Input_Queue);
            this.groupBox4.Location = new System.Drawing.Point(6, 220);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox4.Size = new System.Drawing.Size(395, 68);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Queue";
            // 
            // Input_RouteKey
            // 
            this.Input_RouteKey.Location = new System.Drawing.Point(89, 29);
            this.Input_RouteKey.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Input_RouteKey.Name = "Input_RouteKey";
            this.Input_RouteKey.Size = new System.Drawing.Size(83, 22);
            this.Input_RouteKey.TabIndex = 5;
            this.Input_RouteKey.Text = "MyRouteKey";
            // 
            // Button_DeleteQueue
            // 
            this.Button_DeleteQueue.Location = new System.Drawing.Point(264, 29);
            this.Button_DeleteQueue.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_DeleteQueue.Name = "Button_DeleteQueue";
            this.Button_DeleteQueue.Size = new System.Drawing.Size(86, 22);
            this.Button_DeleteQueue.TabIndex = 4;
            this.Button_DeleteQueue.Text = "Delete Queue";
            this.Button_DeleteQueue.UseVisualStyleBackColor = true;
            this.Button_DeleteQueue.Click += new System.EventHandler(this.Button_DeleteQueue_Click);
            // 
            // Button_CreateQueue
            // 
            this.Button_CreateQueue.Location = new System.Drawing.Point(176, 29);
            this.Button_CreateQueue.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_CreateQueue.Name = "Button_CreateQueue";
            this.Button_CreateQueue.Size = new System.Drawing.Size(86, 22);
            this.Button_CreateQueue.TabIndex = 3;
            this.Button_CreateQueue.Text = "Create Queue";
            this.Button_CreateQueue.UseVisualStyleBackColor = true;
            this.Button_CreateQueue.Click += new System.EventHandler(this.Button_CreateQueue_Click);
            // 
            // Input_Queue
            // 
            this.Input_Queue.Location = new System.Drawing.Point(4, 29);
            this.Input_Queue.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Input_Queue.Name = "Input_Queue";
            this.Input_Queue.Size = new System.Drawing.Size(83, 22);
            this.Input_Queue.TabIndex = 1;
            this.Input_Queue.Text = "MyQueue";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Label_PublishSend);
            this.groupBox5.Controls.Add(this.Input_PublishMessage);
            this.groupBox5.Controls.Add(this.Input_PublishRouteKey);
            this.groupBox5.Controls.Add(this.Button_PublishMessage);
            this.groupBox5.Controls.Add(this.Input_PublishExchange);
            this.groupBox5.Location = new System.Drawing.Point(6, 290);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox5.Size = new System.Drawing.Size(395, 81);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Publish";
            // 
            // Label_PublishSend
            // 
            this.Label_PublishSend.AutoSize = true;
            this.Label_PublishSend.Location = new System.Drawing.Point(6, 56);
            this.Label_PublishSend.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Label_PublishSend.Name = "Label_PublishSend";
            this.Label_PublishSend.Size = new System.Drawing.Size(41, 12);
            this.Label_PublishSend.TabIndex = 7;
            this.Label_PublishSend.Text = "Send ->";
            // 
            // Input_PublishMessage
            // 
            this.Input_PublishMessage.Location = new System.Drawing.Point(174, 29);
            this.Input_PublishMessage.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Input_PublishMessage.Name = "Input_PublishMessage";
            this.Input_PublishMessage.Size = new System.Drawing.Size(83, 22);
            this.Input_PublishMessage.TabIndex = 6;
            this.Input_PublishMessage.Text = " Hello Message";
            // 
            // Input_PublishRouteKey
            // 
            this.Input_PublishRouteKey.Location = new System.Drawing.Point(89, 29);
            this.Input_PublishRouteKey.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Input_PublishRouteKey.Name = "Input_PublishRouteKey";
            this.Input_PublishRouteKey.Size = new System.Drawing.Size(83, 22);
            this.Input_PublishRouteKey.TabIndex = 5;
            this.Input_PublishRouteKey.Text = "MyRouteKey";
            // 
            // Button_PublishMessage
            // 
            this.Button_PublishMessage.Location = new System.Drawing.Point(259, 29);
            this.Button_PublishMessage.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_PublishMessage.Name = "Button_PublishMessage";
            this.Button_PublishMessage.Size = new System.Drawing.Size(86, 22);
            this.Button_PublishMessage.TabIndex = 3;
            this.Button_PublishMessage.Text = "Publish";
            this.Button_PublishMessage.UseVisualStyleBackColor = true;
            this.Button_PublishMessage.Click += new System.EventHandler(this.Button_PublishMessage_Click);
            // 
            // Input_PublishExchange
            // 
            this.Input_PublishExchange.Location = new System.Drawing.Point(4, 29);
            this.Input_PublishExchange.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Input_PublishExchange.Name = "Input_PublishExchange";
            this.Input_PublishExchange.Size = new System.Drawing.Size(83, 22);
            this.Input_PublishExchange.TabIndex = 1;
            this.Input_PublishExchange.Text = "MyExchange";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Label_SubscribeResult);
            this.groupBox6.Controls.Add(this.Button_SubscribeMessage);
            this.groupBox6.Controls.Add(this.Input_SubscribeQueue);
            this.groupBox6.Location = new System.Drawing.Point(6, 384);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox6.Size = new System.Drawing.Size(395, 78);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Subscribe";
            // 
            // Label_SubscribeResult
            // 
            this.Label_SubscribeResult.AutoSize = true;
            this.Label_SubscribeResult.Location = new System.Drawing.Point(6, 56);
            this.Label_SubscribeResult.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Label_SubscribeResult.Name = "Label_SubscribeResult";
            this.Label_SubscribeResult.Size = new System.Drawing.Size(47, 12);
            this.Label_SubscribeResult.TabIndex = 4;
            this.Label_SubscribeResult.Text = "Result ->";
            // 
            // Button_SubscribeMessage
            // 
            this.Button_SubscribeMessage.Location = new System.Drawing.Point(89, 29);
            this.Button_SubscribeMessage.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_SubscribeMessage.Name = "Button_SubscribeMessage";
            this.Button_SubscribeMessage.Size = new System.Drawing.Size(86, 22);
            this.Button_SubscribeMessage.TabIndex = 3;
            this.Button_SubscribeMessage.Text = "Subscribe";
            this.Button_SubscribeMessage.UseVisualStyleBackColor = true;
            this.Button_SubscribeMessage.Click += new System.EventHandler(this.Button_SubscribeMessage_Click);
            // 
            // Input_SubscribeQueue
            // 
            this.Input_SubscribeQueue.Location = new System.Drawing.Point(4, 29);
            this.Input_SubscribeQueue.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Input_SubscribeQueue.Name = "Input_SubscribeQueue";
            this.Input_SubscribeQueue.Size = new System.Drawing.Size(83, 22);
            this.Input_SubscribeQueue.TabIndex = 1;
            this.Input_SubscribeQueue.Text = "MyQueue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 473);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RabbitMQTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Button_CloseConn;
        private System.Windows.Forms.Button Button_OpenConn;
        private System.Windows.Forms.TextBox Input_Connection;
        private System.Windows.Forms.TextBox Input_Exchange;
        private System.Windows.Forms.Button Button_CreateChannel;
        private System.Windows.Forms.Button Button_CloseChannel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Button_CreateExchange;
        private System.Windows.Forms.Button Button_DeleteExchange;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Button_DeleteQueue;
        private System.Windows.Forms.Button Button_CreateQueue;
        private System.Windows.Forms.TextBox Input_Queue;
        private System.Windows.Forms.TextBox Input_RouteKey;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Input_PublishMessage;
        private System.Windows.Forms.TextBox Input_PublishRouteKey;
        private System.Windows.Forms.Button Button_PublishMessage;
        private System.Windows.Forms.TextBox Input_PublishExchange;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Button_SubscribeMessage;
        private System.Windows.Forms.TextBox Input_SubscribeQueue;
        private System.Windows.Forms.Label Label_SubscribeResult;
        private System.Windows.Forms.Label Label_PublishSend;
    }
}

