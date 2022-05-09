class GetPreporuceni {
  final int igracId;
  final List<int> selectedIds;

  GetPreporuceni({
    required this.igracId,
    required this.selectedIds,
  });

  factory GetPreporuceni.fromJson(Map<String, dynamic> json) {
    return GetPreporuceni(
      igracId: json["igracId"],
      selectedIds: json["selectedIds"],
    );
  }

  Map<String, dynamic> toJson() =>
      {"igracId": igracId, "selectedIds": selectedIds};
}
