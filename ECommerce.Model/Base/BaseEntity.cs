using ECommerce.Model.Enums;

namespace ECommerce.Model.Base
{
    public class BaseEntity
    {

        public BaseEntity() 
        {

        
        
        }
        public int Id { get; set; }

        public Guid MasterId { get; set; }

        public DateTime CreatedTime { get; set; }

        public string CreatedComputerName { get; set; }

        public string CreatedIpAddress { get; set; }

        public DateTime UpdatedTime { get; set; }

        public string UpdatedComputerName { get; set; }
        public string UpdatedIpAddress { get; set; }

        public DataStatus DataStatus { get; set; }

        public bool IsActive { get; set; }




    }
}
