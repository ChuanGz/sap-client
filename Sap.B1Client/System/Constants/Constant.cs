namespace Sap.B1Client.System.Constants;

public static class Constant
{
    #region BatchOperation

    public const string B1S_Path_Batch = "/$batch";

    #endregion

    #region Open Document Action

    public const string B1S_AcDoc_CLOSE = "/Close";
    public const string B1S_AcDoc_CANCEL = "/Cancel";

    #endregion Open Document Action

    #region Format & Label

    public const string B1S_Label_Cookie = "Cookie";
    public const string B1S_Label_Prefer = "Prefer";
    public const string B1S_Label_Session = "SessionId";
    public const string B1S_Label_Version = "Version";

    public const string B1S_Label_B1SESSION = "B1SESSION=";
    public const string B1S_Label_Route = "ROUTEID=";
    public const string B1S_Label_ReplaceOnPatch = "B1S-ReplaceCollectionsOnPatch";

    public const string B1S_IID = "({0})";
    public const string B1S_SID = "('{0}')";
    public const string B1S_Label_Odata_MaxPageSize = "Prefer: odata.maxpagesize=100";

    #endregion Format & Label

    #region Session

    public const string B1S_Path_Login = "/b1s/v1/Login";
    public const string B1S_Path_Logout = "/b1s/v1/Logout";

    #endregion Session

    #region MasterData

    public const string B1S_Path_Group_Item = "/b1s/v1/ItemGroups";
    public const string B1S_Path_Group_BusinessPartner = "/b1s/v1/BusinessPartnerGroups";
    public const string B1S_Path_Group_UnitOfMesurement = "/b1s/v1/UnitOfMesurementGroups";

    public const string B1S_Path_Item = "/b1s/v1/Items";
    public const string B1S_Path_BusinessPartner = "/b1s/v1/BusinessPartners";
    public const string B1S_Path_UnitOfMeasurement = "/b1s/v1/UnitOfMeasurements";
    public const string B1S_Path_Warehouse = "/b1s/v1/Warehouses";
    public const string B1S_Path_BusinessPlace = "/b1s/v1/BusinessPlaces";
    public const string B1S_Path_SalesPersons = "/b1s/v1/SalesPersons";

    #endregion MasterData

    #region Marketing

    public const string B1S_Path_Sales_Order = "/b1s/v1/Orders";
    public const string B1S_Path_Sales_Invoice = "/b1s/v1/Invoices";
    public const string B1S_Path_Sales_CreditNote = "/b1s/v1/CreditNotes";

    public const string B1S_Path_Purchase_Order = "/b1s/v1/PurchaseOrders";

    #endregion Marketing

    #region Production

    public const string B1S_Path_Production_Order = "/b1s/v1/ProductionOrders";

    #endregion Production

    #region Stock

    public const string B1S_Path_Stock_Entry = "/b1s/v1/InventoryGenEntries";
    public const string B1S_Path_Stock_Exit = "/b1s/v1/InventoryGenExits";
    public const string B1S_Path_Stock_Transfer = "/b1s/v1/StockTransfers";
    public const string B1S_Path_Stock_Transfer_Request = "/b1s/v1/InventoryTransferRequets";

    #endregion Stock
}