# DnsProject



יצירה של Website- 
הפעולה עוברת על קובץ הtxt ומצמידה שתי שורות:
האחת דומיין והשניה ip
לכדי אובייקט אחד והוא website

אני ממליץ לעבור על refresh(), שם עניין זה מובא היטב.




הפרוייקט מדמה DNS,
בעת ההרצה עולה ממשק פשוט, שמציע שימוש בסיסי ביכולות שהdns  טומן
והעיקר הוא בפונקציה Search() שמקבלת דומיין ולוקחת ממנו את הtld.
לאחר מכן היא תפעיל פונקציית search אחרת, ששייכת למחלקה TLD ובה מתוך ArrayList
של אובייקטיי WEBSITE ייבחר האובייקט שהדומיין שלו שווה לדומיין שסופק לSearch הראשונה. האובייקט שייבחר יוחזר ויודפס.

הפרוייקט ממש מזכיר את תהליך הDNS, לכן בעת סקירת הפרוייקט הייתי ממליץ לחפש אלמנטים ומושגים מהDNS על מנת להבין מהר מי נגד מי.

בתכלס:

הבסיס הוא המחלקה WEBSITE 

 לכל WEBSITE יש ip וdomain צמודים לו, קשר זה הוא הכרחי.

המחלקה TLD
 
בנויה מאררי ליסט של WEBSITE, שכולם חולקים אותו String tld

המחלקה ROOT

בנויה מאררי ליסט של TLD, ובו עיקר העיסוק.
