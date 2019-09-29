namespace Lab_And_Tutor_Finder_System
{
    /// <summary>
    /// Project: Forage
    /// Programmer: Emandleni Moyo s216673380@mandela.ac.za
    /// Date: 2019/09/28
    /// Description: This class defines a single machine. 
    /// </summary>
    /// 

    [System.Runtime.InteropServices.Guid("604B05B9-4C72-4C92-B214-76A53D41838C")]
    class Machine
    {
        private int computerNo;
        private int labNo;
        private string computerDescr;
        private int computerStatus;

        public Machine()
        {

        }

        public Machine(int number, int lab, string description, int status)
        {
            computerNo = number;
            labNo = lab;
            computerDescr = description;
            computerStatus = status;
        }

        public int getComputerNo() {
            return computerNo;
        }

        public int getLabNo() {
            return labNo;
        }

        public string getComputerDescr() {
            return computerDescr;
        }

        public int getComputerStatus() {
            return computerStatus;
        }

        public void setComputerNo(int number) {
            computerNo = number;
        }

        public void setLabNo(int number) {
            labNo = number;
        }

        public void setComputerDescr(string descr) {
            computerDescr = descr;
        }

        public void setComputerStatus(int status) {
            computerStatus = status;
        }
    }
}
