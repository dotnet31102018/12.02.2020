package itay;

public class Program {

	public static void main(String[] args) {
		BillHandler root = new Bill200();
		BillHandler bill100 = new Bill100();
		BillHandler bill25 = new Bill25();
		BillHandler coin5 = new Coin5();
		
		root.setNext(bill100);
		bill100.setNext(bill25);
		bill25.setNext(coin5);
		coin5.setNext(null);
		
		root.handle(585);
		System.out.println("================");
		root.handle(0);
		System.out.println("================");
		root.handle(200);
		
	}

}
