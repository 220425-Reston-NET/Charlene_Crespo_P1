namespace RepairShopv2Model
{

    public class Order
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string RepairType { get; set; }

        private int _NumofDevice;
        public int NumofDevice
        {
            get { return _NumofDevice; }

            set
            {
                if (value > 0)
                {
                    _NumofDevice = value;
                }
                else
                {
                    Console.WriteLine();
                }
            }
        
        }
        
        public string DeviceType { get; set; }


        private int _totalPrice;
        public int TotalPrice
        {
            get { return _totalPrice; }

            set
            {
                if (value > 0)
                {
                    _totalPrice = value;
                }
                else
                {
                    Console.WriteLine();
                }
            }
            
        }
public Order()
        {
            Name = "Chris";
            Location = "RepairShop1 123 crandon ave";
            RepairType = "LCD Screen Replacement";
            NumofDevice = 1;
            DeviceType = "Iphone 13 Max";
            TotalPrice = 200;
        }

        public override string ToString()
        {
            return $"=====Order Info=====\nName: {Name}\nLocation: {Location}\nRepairType: {RepairType}\nNumberofDevice: {NumofDevice}\nDeviceType: {DeviceType}\nTotal: {TotalPrice}\n=========";
        }

        public static List<Order> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}