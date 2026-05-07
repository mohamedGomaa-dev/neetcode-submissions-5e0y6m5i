select customers.name from customers
where customers.id not in (select customers.id from customers
                  join orders on customers.id = orders.customer_id
                  where customers.id = orders.customer_id
                    );