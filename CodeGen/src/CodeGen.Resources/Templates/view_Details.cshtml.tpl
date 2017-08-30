@model {NAMESPACE_MODELS}.{CLASS_NAME_MODEL}

@{
    ViewData["Title"] = "{DETAILS_VIEWNAME}";
}

<h2>{DETAILS_VIEWNAME}</h2>

<div>
    <h4>{CLASS_NAME_MODEL}</h4>
    <hr />
    <dl class="dl-horizontal">
        <!-- BEGIN SECTION FORM -->

        <!-- BEGIN SECTION FIELD AS VAR --><dt>
            @Html.DisplayNameFor(model => model.{VAR.PROPERTYNAME})
        </dt>
        <dd>
            @Html.DisplayFor(model => model.{VAR.PROPERTYNAME})
        </dd>
        <!-- END SECTION FIELD -->

        <!-- END SECTION FORM -->
    </dl>
</div>
<div>
    <a asp-action="{EDIT_VIEWNAME}" asp-route-id="@Model.{PRIMARYKEY_PARAMETERNAME}">{EDIT_VIEWNAME}</a> |
    <a asp-action="{INDEX_VIEWNAME}">Back to List</a>
</div>
