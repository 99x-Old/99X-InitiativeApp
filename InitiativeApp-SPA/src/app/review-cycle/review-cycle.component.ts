import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder } from '@angular/forms';
import { ReviewCycle } from '../_models/reviewCycle';
import { AlertifyService } from '../_services/alertify.service';
import { ReviewCycleService } from '../_services/reviewCycle.service';

@Component({
	selector: 'app-review-cycle',
	templateUrl: './review-cycle.component.html',
	styleUrls: ['./review-cycle.component.css']
})
export class ReviewCycleComponent implements OnInit {

	reviewCycles: ReviewCycle[];
	reviewCycleForms: FormArray = this.fb.array([]);

	constructor(private reviewCycleService: ReviewCycleService, private alertify: AlertifyService, private fb: FormBuilder) { }

	ngOnInit() {
		this.loadReviewCycles();
		this.addReviewCycleForm();
	}

	addReviewCycleForm() {
		this.reviewCycleForms.push(this.fb.group({
			reviewCycleName: [],
			initiativeId: []
		}))
	}

	loadReviewCycles() {
		this.reviewCycleService.getReviewCycles().subscribe((reviewCycles: ReviewCycle[]) => {
			this.reviewCycles = reviewCycles;
		}, error => {
			this.alertify.error(error);
		});
	}

}
