@model IEnumerable<{NAMESPACE_MODELS}.{CLASS_NAME_MODEL}>

@{
    ViewData["Title"] = "{INDEX_VIEWNAME}";
}

<h2>{INDEX_VIEWNAME}</h2>

<p>
    <a asp-action="{CREATE_VIEWNAME}">{CREATE_VIEWNAME} New</a>
</p>
<table class="table">
    <thead>
        <tr>
            <!-- BEGIN SECTION HEADER -->

            <!-- BEGIN SECTION COLUMN AS VAR --><th>
                @Html.DisplayNameFor(model => model.{VAR.PROPERTYNAME})
            </th>
            <!-- END SECTION COLUMN -->

            <!-- END SECTION HEADER -->
            <th></th>
        </tr>
    </thead>
    <tbody>
@foreach (var item in Model) {
        <tr>
            <!-- BEGIN SECTION ROW -->

            <!-- BEGIN SECTION COLUMN AS VAR --><td>
                @Html.DisplayFor(modelItem => item.{VAR.PROPERTYNAME})
            </td>
            <!-- END SECTION COLUMN -->

            <!-- END SECTION ROW -->
            <td>
                <a asp-action="{EDIT_VIEWNAME}" asp-route-id="@item.{PRIMARYKEY_PARAMETERNAME}">{EDIT_VIEWNAME}</a> |
                <a asp-action="{DETAILS_VIEWNAME}" asp-route-id="@item.{PRIMARYKEY_PARAMETERNAME}">{DETAILS_VIEWNAME}</a> |
                <a asp-action="{DELETE_VIEWNAME}" asp-route-id="@item.{PRIMARYKEY_PARAMETERNAME}">{DELETE_VIEWNAME}</a>
            </td>
        </tr>
}
    </tbody>
</table>
