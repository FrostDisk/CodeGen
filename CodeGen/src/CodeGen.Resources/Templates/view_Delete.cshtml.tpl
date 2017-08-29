@model {NAMESPACE_MODELS}.{CLASS_NAME_MODEL}

@{
    ViewData["Title"] = "{DELETE_VIEWNAME}";
}

<h2>{DELETE_VIEWNAME}</h2>

<h3>Are you sure you want to delete this?</h3>
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
    
    <form asp-action="{DELETE_VIEWNAME}">
        <div class="form-actions no-color">
            <input type="submit" value="{DELETE_VIEWNAME}" class="btn btn-default" /> |
            <a asp-action="{INDEX_VIEWNAME}">Back to List</a>
        </div>
    </form>
</div>
