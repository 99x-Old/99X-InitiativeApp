/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ReviewCycleService } from './reviewCycle.service';

describe('Service: ReviewCycle', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ReviewCycleService]
    });
  });

  it('should ...', inject([ReviewCycleService], (service: ReviewCycleService) => {
    expect(service).toBeTruthy();
  }));
});
