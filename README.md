# ShopDiscountRU

Proje, Discount isimli bir adet Post methoda sahip bir Web API projesidir. Aşağıdaki yapıda beir json bekler. Müşteri tipine ve ürün çeşidine göre ürünlere ve toplam fiyata indirim uygular.

## json input

{
  "customer": {
    "registeredDate": "2022-11-19T06:18:30.441Z",
    "isAffiliete": true,
    "isEmployee": true
  },
  "products": [
    {
      "price": 0,
      "isGrocery": true
    }
  ]
}

##
The following discounts apply:
1. If the user is an employee of the store, he gets a 30% discount
2. If the user is an affiliate of the store, he gets a 10% discount
3. If the user has been a customer for over 2 years, he gets a 5% discount.
4. For every $100 on the bill, there would be a $ 5 discount (e.g. for $ 990, you get $ 45
as a discount).
5. The percentage based discounts do not apply on groceries.
6. A user can get only one of the percentage based discounts on a bill.

##
ICustomer interfacinden türetilmiş 4 farklı Customer sınıfı var ve her biri farklı indirim oranlarını barındırıyor. Calculate isimli de bir metodları var. 

IProduct interfacinden türetilmiş 2 farklı Product sınıfı var ve her biri ürünün indirimli fiyatını veren bir metoda sahip.

Invoice sınıfı ICustor ve List<IProduct> nesnelerini barındırıyor ve Calculate isimli metod IUser.Calculate methodunu çağırıyor.

##
Unit test uygulanmıştır.
