class SelectModel {
  final int id;
  final String Name;

  SelectModel(this.id, this.Name);

  Map toJson() => {
    "productID":id,
    "prodName":Name
  };
  factory SelectModel.fromMap(Map<String, dynamic> json) {
    return SelectModel(
        json["id"],
        json["Name"]);
  }
}