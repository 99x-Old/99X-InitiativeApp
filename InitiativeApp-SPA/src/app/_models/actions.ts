
export interface Actions {
	actionId: number;
	actionName: string;
	expiredOn: Date;
	initiativeId: number;
	id: number;
	comments?: Comment[];
}
