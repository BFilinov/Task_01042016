select * from customer t1 join purchase t2 on (t1.customer_id=t2.customer_id)
where 
	t2.product_name='молоко' and 
	month(t2.purchasedate)=month(getdate()) and
	not exists 
		(select 1 from purchase t3 
		 where 
			t3.customer_id=t1.customer_id and 
			t3.product_name='сметана' and 
			month(t3.purchasedate)=month(getdate()
			)
		)