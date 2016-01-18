import $ from 'jquery';
import cookie from 'js/cookie.js';

function encode(username, password) {
    return sha1(username + password).toString();
}

var cookieName = 'sessionKey';
function setSessionKey(sessionKey) {
    cookie.set(cookieName, sessionKey, 10);
}

function getSessionKey() {
    return cookie.get(cookieName);
}

function removeSessionKey() {
    cookie.remove(cookieName);
}

export default {
    users: {
        register: function(username, password) {
          var reqUser = {
            username: username,
            passHash: encode(username, password)
          };

            return $.ajax({
                url: 'api/users',
                type: 'post',
                method: "POST",
                contentType: 'application/json',
                data: JSON.stringify(reqUser)
            })
        },
        login: function(username, password) {
          var reqUser = {
            username: username,
            passHash: encode(username, password)
          };
            return $.ajax({
                url: 'api/auth',
                type: 'put',
                method: "PUT",
                contentType: 'application/json',
                data: JSON.stringify(reqUser)
            })
            .then(function(data) {
                setSessionKey(data.sessionKey);
                return data.username;
            })
        },
        logout: function() {
            return $.ajax({
                url: 'api/users',
                type: 'post',
                method: "POST",
                contentType: 'application/json',
                headers: {
                    'X-SessionKey': getSessionKey()
                }
            })
            .then(function() {
                return removeSessionKey();
            })
        },
        current: function() {
            return getSessionKey();
        }
    },
    cookies: {
        all: function() {
            return $.ajax({
                url: 'api/cookies',
                contentType: 'application/json',
                type: 'get',
                method: "GET",
            });
        },
        add: function(text, category) {
            return $.ajax({
                url: 'api/cookies',
                type: 'post',
                method: "POST",
                contentType: 'application/json',
                data: JSON.stringify({ text, category })
            });
        },
        like: function(like) {
            return $.ajax({
                url: 'api/cookies',
                type: 'put',
                method: "PUT",
                contentType: 'application/json',
                data: JSON.stringify({ like })
            });
        }
    }
}
