using System;
namespace POO
{
    public class Punto
    {
        int x,y;

       public Punto()
        {
            x = 0;
            y = 0; 
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Nuevo(int x, int y)
        {
            this.x = x;
            this.y = y; 
        }
        public void setX(int x)
        {
            this.x = x; 
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public int getX()
        {
            return x; 
        }
        public int getY()
        {
            return y;
        }

        public string Mostrar() {

            return "(" + x.ToString() + "," +y.ToString()+").";
        }

        public string DistanciaHasta(Punto hasta)
        {
            int xdif = hasta.x - this.x ;
            int ydif = hasta.y - this.y ;
            xdif = Math.Abs(xdif);
            ydif = Math.Abs(ydif);

            return "(" + xdif.ToString() + "," + ydif.ToString() + ").";
        }
    }
}
