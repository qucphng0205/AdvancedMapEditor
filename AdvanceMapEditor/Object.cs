using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceMapEditor
{
    class GameObject
    {
        public enum EObjectID
        {
            GROUND,
            NONE
        }

        private int _width;
        private int _height;
        private int _x;
        private int _y;
        private EObjectID _id;
        private int _direct;//0-> left to right; 1-> right to left
        private int _key;

        public int Width {
            get {
                return _width;
            }

            set {
                _width = value;
            }
        }

        public int Height {
            get {
                return _height;
            }

            set {
                _height = value;
            }
        }

        public int X {
            get {
                return _x;
            }

            set {
                _x = value;
            }
        }

        public int Y {
            get {
                return _y;
            }

            set {
                _y = value;
            }
        }

        internal EObjectID Id {
            get {
                return _id;
            }

            set {
                _id = value;
            }
        }

        public int Key {
            get {
                return _key;
            }

            set {
                _key = value;
            }
        }

        public int Direct {
            get {
                return _direct;
            }

            set {
                _direct = value;
            }
        }

        public GameObject() {
        }

        public GameObject(int x, int y, int width, int height, EObjectID id)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Id = id;
        }
    }
}
