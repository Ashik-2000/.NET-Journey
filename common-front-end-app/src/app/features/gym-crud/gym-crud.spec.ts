import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GymCrud } from './gym-crud';

describe('GymCrud', () => {
  let component: GymCrud;
  let fixture: ComponentFixture<GymCrud>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GymCrud]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GymCrud);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
