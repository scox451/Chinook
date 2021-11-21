import { Album, 
	Genre, 
	MediaType, 
	InvoiceItem, 
	PlaylistTrack } from "@models";

export class Track
{
	public trackId: number;
	public name: string;
	public albumId: number;
	public mediaTypeId: number;
	public genreId: number;
	public composer: string;
	public milliseconds: number;
	public bytes: File;
	public unitPrice: number;

	public album:Album;
	public genre:Genre;
	public mediaType:MediaType;

	public invoiceItems: InvoiceItem[];
	public playlistTrack: PlaylistTrack[];

}
