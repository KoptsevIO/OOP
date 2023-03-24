namespace Model
{
    /// <summary>
    /// Класс Child.
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Отец.
        /// </summary>
        private Adult _dad;

        /// <summary>
        /// Мать.
        /// </summary>
        private Adult _mom;

        /// <summary>
        /// Место учёбы.
        /// </summary>
        private string _educationLevel;

        /// <summary>
        /// Информация об отце.
        /// </summary>
        public Adult Dad
        {
            get
            {
                return _dad;
            }

            set
            {
                _dad = value;
            }
        }

        /// <summary>
        /// Информация об отце.
        /// </summary>
        public Adult Mom
        {
            get
            {
                return _mom;
            }

            set
            {
                _mom = value;
            }
        }

        /// <summary>
        /// Место учёбы Child.
        /// </summary>
        public string EducationLevel
        {
            get
            {
                return _educationLevel;
            }

            set
            {
                _educationLevel = value;
            }
        }
    }
}
