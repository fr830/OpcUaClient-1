using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpcUaClient.Model
{
    public class OpcValue
    {
        #region constructor

        public OpcValue()
        {

        }

        public OpcValue(object Value, Opc.Ua.ServiceResult StatusCode)
        {
            this.Value = Value;
            this.StatusCode = StatusCode.StatusCode.Code;
        }

        #endregion

        #region internal fields

        uint statusCode;

        #endregion

        #region public properties
        public object Value { get; set; }

        public bool Status { get; set; }

        public uint StatusCode
        {
            get { return this.statusCode; }
            set
            {
                this.statusCode = value;
                this.Status = Opc.Ua.StatusCode.IsGood(this.statusCode);
            }
        }

        #endregion
    }
}
