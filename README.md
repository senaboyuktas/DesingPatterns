# DesingPatterns
Asp.Net Core 6.0 ile Design Patterns 

[![Kurs Linki](https://img.shields.io/badge/Kurs%20Linki%20-izlemek%20için%20tıklayın-purple)](https://www.udemy.com/course/aspnet-core-6-ile-design-patterns-15-farkl-tasarm-deseni/)

## Proje Hakkında: 
Bu kurs ile tasarım desenlerinin yapısını, Asp.Net Core ile 15 farklı tasarım desenini ve MsSQL, MySQL, MongoDB, PostgreSQL gibi farklı veri tabanlarını kullanarak gerçek bir proje geliştirmeyi öğrendim.

## Aşağıda, işlenen konular sunulmaktadır:

## Chain of Responsibility Design Pattern
Chain of Responsibility, bir işlemin farklı nesneler tarafından işlenebilmesini sağlayan bir davranışsal tasarım desenidir. Bu desen, bir dizi işlemci nesnesini bir zincirde bağlar. Her işlemci, belirli bir işlemi işleyebilir veya zincirdeki bir sonraki işlemciye iletme yeteneğine sahiptir. Bu şekilde, istek zinciri boyunca dolaşır ve uygun işlemciyi bulana kadar işlemi iletebilir.

## CQRS Design Pattern
CQRS (Command Query Responsibility Segregation), bir uygulamanın yazma (komut) işlemlerini ve okuma (sorgu) işlemlerini ayrı işleme yöntemidir. Bu desen, okuma ve yazma işlemlerini farklı model ve depolama mekanizmalarında işleyerek uygulamanın ölçeklenebilirliğini artırır ve karmaşıklığı azaltır.

## Template Method Design Pattern
Template Method, bir sürecin temel bir şablonunu tanımlayan ve bu şablonun belirli adımlarını alt sınıflara bırakan bir davranışsal tasarım desenidir. Bu desen, kod tekrarını azaltır ve alt sınıfların davranışlarını değiştirmelerine izin vererek esneklik sağlar.

## Observer Design Pattern
Observer, bir nesnenin durumundaki değişiklikleri gözlemleyen ve bu değişikliklere yanıt olarak başka nesneleri güncelleyen bir davranışsal tasarım desenidir. Bu desen, birincil nesne ile bağımlı olan ve durum değişikliklerini izleyen gözlemciler arasında bir ilişki kurar.

## Unit Of Work Design Pattern
Unit of Work, bir dizi işlemi birleştiren ve bunları tek bir iş birimi olarak işleyen bir tasarım desenidir. Bu desen, veritabanı işlemlerini gruplayarak veritabanı etkileşimlerini azaltır ve performansı artırır.

## Repository Design Pattern
Repository, veri erişimini soyutlayarak uygulama kodunu veritabanı işlemlerinden ayıran bir yapısal tasarım desenidir. Bu desen, veritabanı işlemlerini ayrı bir katmanda yönetir ve uygulama kodunu veritabanı teknolojisine bağımlı olmaktan kurtarır.

## Composite Design Pattern
Composite, ağaç benzeri bir yapı oluşturmak için nesneleri bir araya getiren bir yapısal tasarım desenidir. Bu desen, tekil nesneleri ve bileşik nesneleri aynı arayüz altında birleştirerek parçaları bütünleştirir.

## Mediator Design Pattern
Mediator, bir nesne grubunun birbirleriyle doğrudan etkileşimini engelleyen ve bunun yerine tüm iletişimi bir aracı nesne üzerinden yöneten bir davranışsal tasarım desenidir. Bu desen, karmaşık sistemlerdeki bağımlılıkları azaltır ve bakımı kolaylaştırır.

## Iterator Design Pattern
Iterator, bir nesne koleksiyonunun elemanlarına sıralı ve tekrarlanabilir bir şekilde erişmek için bir arayüz sağlayan bir davranışsal tasarım desenidir. Bu desen, koleksiyon yapısının detaylarından bağımsız olarak elemanlara erişimi kolaylaştırır.

## Facade Design Pattern
Facade, bir alt sistemden gelen karmaşık bir arayüzü basitleştiren ve istemci kodunun karmaşıklığını azaltan bir yapısal tasarım desenidir. Bu desen, istemci kodunun karmaşıklığını azaltarak alt sistemlerle olan etkileşimi kolaylaştırır.

## Decorator Design Pattern
Decorator, bir nesneye dinamik olarak davranış ekleyen ve nesnenin temel davranışını değiştirmeyen bir yapısal tasarım desenidir. Bu desen, nesne davranışlarını parçalara böler ve esneklik sağlar.
