/* globals module */
function solve() {
  return function(selector){
    $(selector).html(`
   {{#authors}}
		{{#if right}}
			<div class="box right">
		{{else}}
			<div class="box">
		{{/if}}
			<div class="inner">
				<p><img alt="{{name}}" src="{{image}}" width="100" height="133"></p>
				<div>
					<h3>{{name}}</h3>
					<p>{{{titles.[0]}}}</p><p>{{titles.[1]}}</p>
					<ul>
					{{#if urls.[0]}}
						<li><a href="{{urls.[0]}}" target="_blank">{{urls.[0]}}</a></li>
					{{/if}}
					{{#if urls.[1]}}
					<li><a href="{{urls.[1]}}" target="_blank">{{urls.[1]}}</a></li>
					{{/if}}
					</ul>
				</div>
			</div>
		</div>
	{{/authors}}`);
  }
}

module.exports = solve;