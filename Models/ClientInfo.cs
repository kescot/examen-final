public class ClientInfo {
    public int ID { get; set; }
    public string InfoType { get; set; } // e.g., Address, Contact, Financial
    public DateTime CreationDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public string CreatedBy { get; set; }
    public bool Status { get; set; }
    public int ClientID { get; set; }
    public Client Client { get; set; }
}