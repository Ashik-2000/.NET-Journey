import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GymAddEdit } from './gym-add-edit';

describe('GymAddEdit', () => {
  let component: GymAddEdit;
  let fixture: ComponentFixture<GymAddEdit>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GymAddEdit]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GymAddEdit);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
