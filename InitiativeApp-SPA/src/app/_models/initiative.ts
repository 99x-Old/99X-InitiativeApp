import { Meeting } from './meeting';
import { ReviewCycle } from './reviewCycle';

export interface Initiative {
	initiativeId: number;
	initiativeName: string;
	description : string;
	inCharge : string;
	meetings? : Meeting[];
	reviewCycles? : ReviewCycle[];
}