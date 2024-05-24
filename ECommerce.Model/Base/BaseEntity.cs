using ECommerce.Model.Enums;
using ECommerce.Model.Interfaces;

namespace ECommerce.Model.Base
{
    public abstract class BaseEntity : IEntity<Guid>
    {
        public BaseEntity() 
        {
            Status=DataStatus.Inserted;
           MasterId= Guid.NewGuid();
            CreatedTime= DateTime.Now;
            CreatedComputerName=System.Environment.MachineName;
            CreatedIpAddress = "";//todo=Ip adresi tayin edilen ayrı bir katmanda yer alacak.
            IsActive = true;

        }
        public int Id { get ; set ; }
        public Guid MasterId { get ; set ; }
        public DateTime CreatedTime { get ; set ; }
        public string CreatedComputerName { get ; set ; }
        public string CreatedIpAddress { get ; set ; }
        public DateTime UpdatedTime { get ; set ; }

        public string UpdatedComputerName { get; set; }

        public string UpdatedIpAddress { get ; set ; }
        public bool IsActive { get ; set ; }
        public DataStatus Status { get ; set ; }
    }
}
