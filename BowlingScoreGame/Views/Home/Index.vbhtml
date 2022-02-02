<style>
    .button {
        border: none;
        color: white;
        padding: 15px 32px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 16px;
        margin: 4px 2px;
        cursor: pointer;
    }
    .button1 {
        background-color: #008CBA;
        color: black;
    }
    .button2 {
        background-color: #f44336;
        color: black;
    }
    .td {
        background-color: darkgray;
    }

</style>
<div class="jumbotron">
    <center><h1>Bowling Game</h1></center> <br />
    <p> <b>Direction in playing the  game;</b></p> <br />
    <p>Enter x or X for a strike.</p> <br />
    <p>Enter / for a spare</p> <br />
    <p>Enter 0-9 for each shot if it is not a strike or spare.</p> <br />
    <p>The cursor will auto-advance to the next shot (or next frame in case of a strike).</p> <br />
    <p>Use the bottom row of textboxes to test your scoring knowledge against the actual score.</p>

    <form name="theform" onsubmit="return verify();" action="http://jazzychad.com/bowling/docalc.php" method="post">
        <table color="#FFFFFF" borderColor="#FFFFFF" cellSpacing="0" cellPadding="0" align="center" border="1">
            <tbody>
               
                <tr style="background-color:#808080">
                    <td align="center">1</td>
                    <td align="center">2</td>
                    <td align="center">3</td>
                    <td align="center">4</td>
                    <td align="center">5</td>
                    <td align="center">6</td>
                    <td align="center">7</td>
                    <td align="center">8</td>
                    <td align="center">9</td>
                    <td align="center">10</td>
                </tr>
                <tr style="background-color:#008080">
                    <td vAlign="top" align="right">
                        <table cellSpacing="1" cellPadding="5">
                            <tbody>
                                <tr align="top">
                                    <td><input onkeyup="advance2(this, 'shot1', 'shot2')" tabIndex="1" maxLength="1" size="1" name="shot0"></td>
                                    <td style="BORDER-RIGHT: 1px solid; BORDER-TOP: 1px solid; BORDER-LEFT: 1px solid; BORDER-BOTTOM: 1px solid" ><input onkeyup="advance(this, 'shot2')" tabIndex="2" maxLength="1" size="1" name="shot1"></td>
                                </tr>
                                <tr height="40">
                                    <td align="right" colSpan="2"><input tabIndex="21" size="3" name="frame0"></td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td vAlign="top" align="right">
                        <table cellSpacing="1" cellPadding="5">
                            <tbody>
                                <tr align="top">
                                    <td><input onkeyup="advance2(this, 'shot3', 'shot4')" tabIndex="3" maxLength="1" size="1" name="shot2"></td>
                                    <td style="BORDER-RIGHT: 1px solid; BORDER-TOP: 1px solid; BORDER-LEFT: 1px solid; BORDER-BOTTOM: 1px solid"><input onkeyup="advance(this, 'shot4')" tabIndex="4" maxLength="1" size="1" name="shot3"></td>
                                </tr>
                                <tr height="40">
                                    <td align="right" colSpan="2"><input tabIndex="22" size="3" name="frame1"></td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td vAlign="top" align="right">
                        <table cellSpacing="1" cellPadding="5">
                            <tbody>
                                <tr align="top">
                                    <td><input onkeyup="advance2(this, 'shot5', 'shot6')" tabIndex="5" maxLength="1" size="1" name="shot4"></td>
                                    <td style="BORDER-RIGHT: 1px solid; BORDER-TOP: 1px solid; BORDER-LEFT: 1px solid; BORDER-BOTTOM: 1px solid"><input onkeyup="advance(this, 'shot6')" tabIndex="6" maxLength="1" size="1" name="shot5"></td>
                                </tr>
                                <tr height="40">
                                    <td align="right" colSpan="2"><input tabIndex="23" size="3" name="frame2"></td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td vAlign="top" align="right">
                        <table cellSpacing="1" cellPadding="5">
                            <tbody>
                                <tr align="top">
                                    <td><input onkeyup="advance2(this, 'shot7', 'shot8')" tabIndex="7" maxLength="1" size="1" name="shot6"></td>
                                    <td style="BORDER-RIGHT: 1px solid; BORDER-TOP: 1px solid; BORDER-LEFT: 1px solid; BORDER-BOTTOM: 1px solid"><input onkeyup="advance(this, 'shot8')" tabIndex="8" maxLength="1" size="1" name="shot7"></td>
                                </tr>
                                <tr height="40">
                                    <td align="right" colSpan="2"><input tabIndex="24" size="3" name="frame3"></td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td vAlign="top" align="right">
                        <table cellSpacing="1" cellPadding="5">
                            <tbody>
                                <tr align="top">
                                    <td><input onkeyup="advance2(this, 'shot9', 'shot10')" tabIndex="9" maxLength="1" size="1" name="shot8"></td>
                                    <td style="BORDER-RIGHT: 1px solid; BORDER-TOP: 1px solid; BORDER-LEFT: 1px solid; BORDER-BOTTOM: 1px solid"><input onkeyup="advance(this, 'shot10')" tabIndex="10" maxLength="1" size="1" name="shot9"></td>
                                </tr>
                                <tr height="40">
                                    <td align="right" colSpan="2"><input tabIndex="25" size="3" name="frame4"></td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td vAlign="top" align="right">
                        <table cellSpacing="1" cellPadding="5">
                            <tbody>
                                <tr align="top">
                                    <td><input onkeyup="advance2(this, 'shot11', 'shot12')" tabIndex="11" maxLength="1" size="1" name="shot10"></td>
                                    <td style="BORDER-RIGHT: 1px solid; BORDER-TOP: 1px solid; BORDER-LEFT: 1px solid; BORDER-BOTTOM: 1px solid"><input onkeyup="advance(this, 'shot12')" tabIndex="12" maxLength="1" size="1" name="shot11"></td>
                                </tr>
                                <tr height="40">
                                    <td align="right" colSpan="2"><input tabIndex="26" size="3" name="frame5"></td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td vAlign="top" align="right">
                        <table cellSpacing="1" cellPadding="5">
                            <tbody>
                                <tr align="top">
                                    <td><input onkeyup="advance2(this, 'shot13', 'shot14')" tabIndex="13" maxLength="1" size="1" name="shot12"></td>
                                    <td style="BORDER-RIGHT: 1px solid; BORDER-TOP: 1px solid; BORDER-LEFT: 1px solid; BORDER-BOTTOM: 1px solid"><input onkeyup="advance(this, 'shot14')" tabIndex="14" maxLength="1" size="1" name="shot13"></td>
                                </tr>
                                <tr height="40">
                                    <td align="right" colSpan="2"><input tabIndex="27" size="3" name="frame6"></td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td vAlign="top" align="right">
                        <table cellSpacing="1" cellPadding="5">
                            <tbody>
                                <tr align="top">
                                    <td><input onkeyup="advance2(this, 'shot15', 'shot16')" tabIndex="15" maxLength="1" size="1" name="shot14"></td>
                                    <td style="BORDER-RIGHT: 1px solid; BORDER-TOP: 1px solid; BORDER-LEFT: 1px solid; BORDER-BOTTOM: 1px solid"><input onkeyup="advance(this, 'shot16')" tabIndex="16" maxLength="1" size="1" name="shot15"></td>
                                </tr>
                                <tr height="40">
                                    <td align="right" colSpan="2"><input tabIndex="28" size="3" name="frame7"></td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td vAlign="top" align="right">
                        <table cellSpacing="1" cellPadding="5">
                            <tbody>
                                <tr align="top">
                                    <td><input onkeyup="advance2(this, 'shot17', 'shot18')" tabIndex="17" maxLength="1" size="1" name="shot16"></td>
                                    <td style="BORDER-RIGHT: 1px solid; BORDER-TOP: 1px solid; BORDER-LEFT: 1px solid; BORDER-BOTTOM: 1px solid"><input onkeyup="advance(this, 'shot18')" tabIndex="18" maxLength="1" size="1" name="shot17"></td>
                                </tr>
                                <tr height="40">
                                    <td align="right" colSpan="2"><input tabIndex="29" size="3" name="frame8"></td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td vAlign="top" align="right">
                        <table cellSpacing="1" cellPadding="5">
                            <tbody>
                                <tr align="top">
                                    <td><input onkeyup="advance(this, 'shot19')" tabIndex="18" maxLength="1" size="1" name="shot18"></td>
                                    <td style="BORDER-RIGHT: 1px solid; BORDER-TOP: 1px solid; BORDER-LEFT: 1px solid; BORDER-BOTTOM: 1px solid"><input onkeyup="advance(this, 'shot20')" tabIndex="19" maxLength="1" size="1" name="shot19"></td>
                                    <td style="BORDER-RIGHT: 1px solid; BORDER-TOP: 1px solid; BORDER-LEFT: 1px solid; BORDER-BOTTOM: 1px solid"><input tabIndex="20" maxLength="1" size="1" name="shot20"></td>
                                </tr>
                                <tr height="40">
                                    <td align="right" colSpan="2"><input tabIndex="30" size="3" name="frame9"></td>
                                </tr>
                            </tbody>
                        </table>
                       
                    </td>
                </tr>
            </tbody>
        </table>
        <p><center><input type="hidden" value="yes" name="submitted"> <input type="submit" class="button button1" value="Calculate Score"><input type="reset" class="button button2" value="Reset"></center></p>
    </form>
    <p>&nbsp;</p>
</div>

<div class="row">
    <div class="col-md-4">
        <h2>Getting started</h2>
        <p>ASP.NET Web API is a framework that makes it easy to build HTTP services that reach
        a broad range of clients, including browsers and mobile devices. ASP.NET Web API
        is an ideal platform for building RESTful applications on the .NET Framework.
        </p>
        <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301870">Learn more &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2>Get more libraries</h2>
        <p>NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.</p>
        <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301871">Learn more &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2>Web Hosting</h2>
        <p>You can easily find a web hosting company that offers the right mix of features and price for your applications.</p>
        <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301872">Learn more &raquo;</a></p>
    </div>
</div>
