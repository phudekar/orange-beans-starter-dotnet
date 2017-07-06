using System;
using System.Security.Cryptography;

namespace OrangeBeans
{
  public class PaymentGateway
  {
    public string InitiatePayment(float total, int correlationID)
    {
      return correlationID.ToString();
    }
  }
}