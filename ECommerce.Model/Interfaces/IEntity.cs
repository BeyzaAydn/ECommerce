using ECommerce.Model.Enums;

namespace ECommerce.Model.Interfaces
{
    public  interface IEntity<T>
    {
        //Id

        public int Id { get; set; }
        public T MasterId { get; set; }

        //Created
        public DateTime CreatedTime { get; set; }
        public string CreatedComputerName {  get; set; }
        public string CreatedIpAddress {  get; set; }   

        //Updated

        public DateTime UpdatedTime { get; set; }
        public string UpdatedComputerName { get;}
        public string UpdatedIpAddress { get; set;}

        public bool IsActive {  get; set; }
        public DataStatus Status { get; set; }

    }
}
