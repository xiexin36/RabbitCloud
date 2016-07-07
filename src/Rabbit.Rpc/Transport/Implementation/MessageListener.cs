﻿using Rabbit.Rpc.Messages;

namespace Rabbit.Rpc.Transport.Implementation
{
    /// <summary>
    /// 消息监听者。
    /// </summary>
    public class MessageListener : IMessageListener
    {
        #region Implementation of IMessageListener

        /// <summary>
        /// 接收到消息的事件。
        /// </summary>
        public event ReceivedDelegate Received;

        /// <summary>
        /// 触发接收到消息事件。
        /// </summary>
        /// <param name="sender">消息发送者。</param>
        /// <param name="message">接收到的消息。</param>
        public void OnReceived(IMessageSender sender, TransportMessage message)
        {
            Received?.Invoke(sender, message);
        }

        #endregion Implementation of IMessageListener
    }
}