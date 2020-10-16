/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { InitiativeService } from './initiative.service';

describe('Service: Initiative', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [InitiativeService]
    });
  });

  it('should ...', inject([InitiativeService], (service: InitiativeService) => {
    expect(service).toBeTruthy();
  }));
});
