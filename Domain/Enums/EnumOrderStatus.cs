namespace Orders.Domain.Enums
{
    public enum EnumOrderStatus
    {
        CREATED = 0,
        PAYMENT_PENDING= 1,
        SEPARATING = 2,
        SHIPPED = 3,
        DELIVERED = 4,
        CANCELED = 5
    }
}
