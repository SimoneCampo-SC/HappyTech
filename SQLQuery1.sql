select * from Section where 'section_ID' =
(select section_ID from PersonalSection
where template_ID =
(SELECT Id FROM Template 
where tempType = 'CV') 
						)