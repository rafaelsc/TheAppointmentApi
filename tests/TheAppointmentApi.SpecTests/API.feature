Feature: API

Scenario: A 'user' can list all free appointment slots in future date.
   Given a future date, and the TheAppointmentApi have 3 free slots that day.
    When restfull GET request is done to the API endpoint
	Then a list of all 3 free same slots should be return.

Scenario: A 'user' can list all free appointment slots past date .
   Given a past date, and the TheAppointmentApi have 3 free slots that day.
    When restfull GET request is done to the API endpoint
	Then a Bad Request error should return

Scenario: A 'user' can list all free appointment slots in a future busy date.
   Given a past date, and the TheAppointmentApi have 0 free slots that day.
    When restfull GET request is done to the API endpoint
	Then a list of all 0 free same slots should be return.

