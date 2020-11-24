select name from Section where Id IN
(select section_ID from PersonalSection where template_ID =
(select Id from Template where tempType = 'CV'))