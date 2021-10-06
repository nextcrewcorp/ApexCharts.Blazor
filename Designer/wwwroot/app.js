window.app = {
    toggleCollapsible: function (id) {
        let $e = document.getElementById(id)

        if ($e) {
            $e.classList.toggle('collapse')
        }
    }
}