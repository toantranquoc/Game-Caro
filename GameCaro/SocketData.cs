using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    [Serializable]
    public class SocketData
    {
        private int command;
        private Point point;
        private string message;
        private int soHuu;

        public int Command
        {
            get
            {
                return command;
            }

            set
            {
                command = value;
            }
        }

        public Point Point
        {
            get
            {
                return point;
            }

            set
            {
                point = value;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }

        public int SoHuu
        {
            get
            {
                return soHuu;
            }

            set
            {
                soHuu = value;
            }
        }
        public SocketData(int command, string message, Point point)
        {
            this.Command = command;
            this.Point = point;
            this.Message = message;
        }
        public SocketData(int command, string message, Point point, int sohuu)
        {
            this.Command = command;
            this.Point = point;
            this.Message = message;
            this.SoHuu = sohuu;
        }

    }
    public enum SocketCommand
    {
        SEND_POINT,
        NOTIFY,
        NEW_GAME,
        QUIT,
        MESSAGE,
        CONNECT
    }
}
