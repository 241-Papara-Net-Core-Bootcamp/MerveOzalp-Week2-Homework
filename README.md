# Middleware nedir? 
### Basit haliyle Middleware ara yazılım demektir. Basit bir web uygulamasında, istemciden gelen request’e karşılık olarak response gönderilmektedir.

## Middleware Metotlar Nelerdir?

### Run(): Request bu metoda düştükten sonra pipeline üzerindeki işlemler devam etmez, bir nevi kısa devre oluşturur. Dolayısıyla kullanıldığı yeden sonraki middleware ### tetiklenmeyeceğinden dolayı akış kesilecektir.
### Use(): Bu metot ile bir sonraki sırada olan middleware üyesine erişim sağlayabiliriz. Run metodunun aksine iki parametre almaktadır. Bunlar context ve task 
### parametresidir. Task parametresi kendisinden sonra çalışacak olan middleware’in çalışmasını bekler ve o bittikten sonra kendini tamamlar.
### Map(): Map metodu, Middleware’i belirli URL’ye eşlemek için kullanılır.

[Medium](https://mustafaonurtasdemirr.medium.com/middleware-nedir-ecdef1409fa) - Bilgi için kullanılan kaynaktır. Detay için inceleyebilirsiniz.
