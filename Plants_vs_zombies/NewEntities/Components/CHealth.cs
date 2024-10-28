using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PvZ.Components
{
    class CHealth : Component
    {
        // Điểm sống ban đầu
        private int initialHP;
        public int HP { get; set; } // Điểm sống hiện tại

        // Phương thức cập nhật trạng thái của component
        public override void Update()
        {
            // Nếu không còn sống, đánh dấu đối tượng là không hoạt động
            if (!isAlive)
                Parent.Inactive = true;

            // Reset trạng thái đã bị va chạm
            if (HasBeenHit)
                HasBeenHit = false;
        }

        // Điểm sống ban đầu
        public int InitialHP
        {
            get
            {
                return initialHP;
            }
            set
            {
                HP = value; // Cập nhật điểm sống hiện tại
                initialHP = value; // Cập nhật điểm sống ban đầu
            }
        }

        // Phương thức đánh dấu đối tượng đã chết
        public void Die() { HP = 0; }

        // Kiểm tra xem đối tượng còn sống hay không
        public bool isAlive
        {
            get
            {
                return HP > 0; // Trả về true nếu còn điểm sống
            }
        }

        public bool HasBeenHit { get; internal set; } // Trạng thái đã bị va chạm

        // Phương thức nhận sát thương
        public void GetDamage(int damage)
        {
            HP -= damage; // Giảm điểm sống theo sát thương nhận được
            HasBeenHit = true; // Đánh dấu là đã bị va chạm
        }
    }
}
