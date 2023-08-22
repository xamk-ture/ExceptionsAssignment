using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssignment
{
    public class DatabaseConnection
    {
        private bool isConnected;

        public void Connect()
        {
            if (new Random().Next(0, 4) == 0) // 25% mahdollisuus, että yhteys epäonnistuu.
            {
                isConnected = false;
                throw new InvalidOperationException("Tietokantayhteys epäonnistui.");
            }
            
            isConnected = true;
        }

        public bool IsConnected()
        {
            return isConnected;
        }
    }
}
