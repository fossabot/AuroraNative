﻿using Newtonsoft.Json;

namespace AuroraNative.EventArgs
{
    /// <summary>
    /// 提供用于描述消息事件中群聊消息事件参数的类
    /// </summary>
    public sealed class GroupMessageArgs : MessageEventArgs
    {
        #region --属性--

        /// <summary>
        /// 群号
        /// </summary>
        [JsonProperty(PropertyName = "group_id")]
        public long GroupID { get; private set; }

        /// <summary>
        /// 匿名消息
        /// </summary>
        [JsonProperty(PropertyName = "anonymous")]
        public Anonymous Anonymous { get; private set; }

        #endregion

        #region --构造函数--

        /// <summary>
        /// 初始化 <see cref="MessageEventArgs"/> 类的新实例
        /// </summary>
        /// <param name="TimeStamp">事件发生的时间戳</param>
        /// <param name="SelfID">收到事件的机器人QQ号</param>
        /// <param name="PostType">上报类型</param>
        /// <param name="MessageType">消息类型</param>
        /// <param name="SubType">消息子类型</param>
        /// <param name="MessageID">消息ID</param>
        /// <param name="GroupID">群号</param>
        /// <param name="UserID">发送者QQ号</param>
        /// <param name="Anonymous">匿名消息</param>
        /// <param name="Message">消息内容</param>
        /// <param name="RawMessage">原始消息内容</param>
        /// <param name="Font">字体</param>
        /// <param name="Sender">发送者信息</param>
        public GroupMessageArgs(long TimeStamp, long SelfID, string PostType, string MessageType, string SubType, int MessageID, long GroupID, long UserID, Anonymous Anonymous, string Message, string RawMessage, int Font, Sender Sender) : base(TimeStamp, SelfID, PostType, MessageType, SubType, MessageID, UserID, Message, RawMessage, Font, Sender)
        {
            this.GroupID = GroupID;
            this.Anonymous = Anonymous;
        }

        #endregion
    }
}
