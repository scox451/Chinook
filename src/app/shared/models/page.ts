export class Page
{
	  limit: number = 0;
	  offset: number= 0;
	  count:number= 0;
	  next: number= 0;
	  previous: number= 0;
	  pageIndex: number = 0;

	  constructor( limit:number){
		  this.limit = limit;
	  }
}