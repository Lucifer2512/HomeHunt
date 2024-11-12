namespace BusinessLogicLayer.Types;
public record CreatePaymentLinkRequest(
    string productName,
    string description,
    int price,
    string returnUrl,
    string cancelUrl,
    string buyerName,
    string buyerPhone
);