namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Address { get; set; }
        public long Customer_PhoneNo { get; set; }
    }
    public class TodoBoarding_Type
    {
        public string National_VS_International { get; set; }
    }
    public class TodoBranch_Details
    {
        public string Branch_Id { get; set; }
        public string Branch_Name { get; set; }
        public string Branch_Location { get; set; }
    }
    public class TodoDistributor_info
    {
        public string Dist_Id { get; set; }
        public string Dist_Name { get; set; }
        public string Dist_Location { get; set; }
    }
    public class TodoIndian_Cargo_Shipment
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email  { get; set; }
        public string Address { get; set; }
        public string Phone_No  { get; set; }
    }
    public class Todoorderstatus
    {
        public string Product_Id{ get; set; }
        public string Product_name { get; set; }
        public string orderdate { get; set; }
        public int orderamount { get; set; }
        public string deliverydate { get; set; }
        
    }
    public class TodoProducts_Category
    {
        public string Product_Id{ get; set; }
        public string Product_Name{ get; set; }
        public string Product_Availability{ get; set; }   
    }
    public class TodoProducts_Details
    {
        public string Product_Id { get; set; }
        public string Product_Name { get; set; }
    }
    public class TodoTransaction_Details
    {
        public string Cust_Id{ get; set; }
        public string Product_Id{ get; set; }
        public int No_Of_Transactions { get; set; }
        public long Transaction_Amount { get; set; }
        
    }
}