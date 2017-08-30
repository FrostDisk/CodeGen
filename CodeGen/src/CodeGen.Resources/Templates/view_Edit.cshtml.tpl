@model {NAMESPACE_MODELS}.{CLASS_NAME_MODEL}

@{
    ViewData["Title"] = "{EDIT_VIEWNAME}";
}

<h2>{EDIT_VIEWNAME}</h2>

<form asp-action="{EDIT_VIEWNAME}">
    <div class="form-horizontal">
        <h4>{CLASS_NAME_MODEL}</h4>
        <hr />
        <div asp-validation-summary="ModelOnly" class="text-danger"></div>
        <input type="hidden" asp-for="{PRIMARYKEY_PARAMETERNAME}" />
        <!-- BEGIN SECTION FORM -->

        <!-- BEGIN SECTION FIELD AS VAR --><div class="form-group">
            <label asp-for="{VAR.PROPERTYNAME}" class="col-md-2 control-label"></label>
            <div class="col-md-10">
                <input asp-for="{VAR.PROPERTYNAME}" class="form-control" />
                <span asp-validation-for="{VAR.PROPERTYNAME}" class="text-danger" />
            </div>
        </div>
        <!-- END SECTION FIELD -->

        <!-- END SECTION FORM -->
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
            </div>
        </div>
    </div>
</form>

<div>
    <a asp-action="{INDEX_VIEWNAME}">Back to List</a>
</div>

@section Scripts {
    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
}
