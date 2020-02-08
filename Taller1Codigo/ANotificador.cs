namespace Taller1Codigo
{
    public class ANotificador
    {
        private Usuario user;

        public Usuario User
        {
            get { return user; }
            set { user = value; }
        }

        public void enviar ( string mensaje )
        {
            foreach ( var enviarNot in user.Notificaciones )
            {
                enviarNot.enviar(mensaje);
            }
        }
    }
}