import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder } from '@angular/forms';
import { Initiative } from '../_models/initiative';
import { AlertifyService } from '../_services/alertify.service';
import { InitiativeService } from '../_services/initiative.service';

@Component({
	selector: 'app-initiatives',
	templateUrl: './initiatives.component.html',
	styleUrls: ['./initiatives.component.css']
})
export class InitiativesComponent implements OnInit {

	initiatives: Initiative[];
	initiativeForms: FormArray = this.fb.array([]);

	constructor(private initiativeService: InitiativeService, private alertify: AlertifyService, private fb: FormBuilder) { }

	ngOnInit() {
		this.loadInitiatives();
		this.addInitiativeForm();
	}

	addInitiativeForm() {
		this.initiativeForms.push(this.fb.group({
			initiativeId: [],
			initiativeName: [''],
			description: [''],
			inCharge: ['']
		}))
	}

	loadInitiatives() {
		this.initiativeService.getInitiatives().subscribe((initiatives: Initiative[]) => {
			this.initiatives = initiatives;
		}, error => {
			this.alertify.error(error);
		});
	}
}
