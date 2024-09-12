using StrategyPattern;

PaymentContext paymentContext = new PaymentContext();

// Pay using Credit Card
paymentContext.SetPaymentStrategy(new CreditCardPayment("1234-5678-9012-3456"));
paymentContext.ProcessPayment(100.0);

// Pay using PayPal
paymentContext.SetPaymentStrategy(new PayPalPayment("user@example.com"));
paymentContext.ProcessPayment(200.0);

// Pay using Bank Transfer
paymentContext.SetPaymentStrategy(new BankTransferPayment("987654321"));
paymentContext.ProcessPayment(300.0);