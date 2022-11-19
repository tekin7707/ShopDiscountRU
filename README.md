# ShopsRUs

Proje, Discount isimli bir adet Post methoda sahip bir Web API projesidir.

##json input

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

Müşteri tipine ve ürün çeşidine göre ürünlere ve toplam fiyata indirim uygular.

##
ICustomer interfacinden türetilmiş 4 farklı Customer sınıfı var ve her biri farklı indirim oranlarını barındırıyor. Calculate isimli de bir metodları var. 

IProduct interfacinden türetilmiş 2 farklı Product sınıfı var ve her biri ürünün indirimli fiyatını veren bir metoda sahip.

Invoice sınıfı ICustor ve List<IProduct> nesnelerini barındırıyor ve Calculate isimli metod IUser.Calculate methodunu çağırıyor.

