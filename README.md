Testleri Yapmak İçin aşağıdaki API'ları çalıştırabilirsiniz;

---------------------------Sepete Ürün Ekleme--------------------------

(POST) https://localhost:5001/api/Cart/Create?productId=1

	
{
	"Id":1,
	"Amount":5
}


-------------Sepete Kupon Ekleme ve Koşullar Sağlanırsa İndirim Yapılması--------------
 
(POST)  https://localhost:5001/api/Cart/applyCoupon  


{
	"DiscountTypeId": 1,
	"Price":25.0000,
	"DiscountRate":10
}

-------------Sepette Kampanyalı Olan Kategorilerin Eğer Koşullar Sağlanıyorsa İndirim Yapılması------------

(POST) https://localhost:5001/api/Cart/applyDiscounts

[{
  
  "categoryId": 1,
  "discountTypeId": 1,
  "discountRate": 10,
  "amountLimit": 20
},
{

  "categoryId": 2,
  "discountTypeId": 2,
  "discountRate": 30,
  "amountLimit": 1
}
]

-------------Teslimat Tutarı Hesaplama--------------

(POST) https://localhost:5001/api/Delivery/calculateDelivery

{
	"ProductId": 1,
	"Amount":10,
	"TotalPrice":45

}

-------------------CampaignDiscount------------------
(GET) https://localhost:5001/api/Cart/CampaignDiscount

------------------CouponDiscount--------------------
(GET) https://localhost:5001/api/Cart/CouponDiscount

-------------------DeliveryCost---------------------
(GET) https://localhost:5001/api/Cart/DeliveryCost

-----------------TotalAmountAfterDiscount-----------
(GET) https://localhost:5001/api/Cart/TotalAmountAfterDiscount
