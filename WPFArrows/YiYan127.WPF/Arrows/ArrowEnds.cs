namespace YiYan127.WPF.Arrows
{
    using System;

    /// <summary>
    /// ��ͷ���ڶ�
    /// </summary>
    [Flags]
    public enum ArrowEnds
    {
        /// <summary>
        /// �޼�ͷ
        /// </summary>
        None = 0,

        /// <summary>
        /// ��ʼ�����ͷ
        /// </summary>
        Start = 1,

        /// <summary>
        /// ���������ͷ
        /// </summary>
        End = 2,

        /// <summary>
        /// ���˼�ͷ
        /// </summary>
        Both = 3
    }
}