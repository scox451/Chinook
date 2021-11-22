import { Pagination, TrackDetails } from "@models";

export interface TracksResult
{
	 data: TrackDetails[],
	 pagination: Pagination

}