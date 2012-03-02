function DeliveriesViewModel() {

    var self = this;
    var dataSourceOptions = {
        providerParameters: {
            url: '/api/DataService',
            operationName: 'GetDeliveriesForToday'
        },
        entityType: 'Delivery:#TechDaysOnePageApp.Models',
        bufferChanges: false,
        mapping: Delivery
    };

    self.dataSource = new upshot.RemoteDataSource(dataSourceOptions).refresh();
    self.deliveries = self.dataSource.getEntities();
};

function Customer(data) {
    var self = this;

    self.CustomerId = ko.observable(data.CustomerId);
    self.Name = ko.observable(data.Name);
    self.Address = ko.observable(data.Address);
    upshot.addEntityProperties(self, 'Customer:#TechDaysOnePageApp.Models');
};

function Delivery(data) {
    var self = this;

    self.DeliveryId = ko.observable(data.DeliveryId);
    self.CustomerId = ko.observable(data.CustomerId);
    self.Customer = ko.observable(data.Customer);
    self.Description = ko.observable(data.Description);
    self.IsDelivered = ko.observable(data.IsDelivered);
    upshot.addEntityProperties(self, 'Delivery:#TechDaysOnePageApp.Models');
}