Install
=======

    PM> Install-Package PluralizationServices

How to use
==========

    PluralizationService service = new PortuguesePluralizationService();
	string plural = service.Pluralize("produto");
	string singular = service.Singularize("produtos");