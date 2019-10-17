using System;
using System.Collections.Generic;
using System.Text;

namespace DapperDemo
{
    public class Address
    {
        public Address()
        {
        }
        public long? Row_Id { get; set; }
        public long? CreateBy { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastUpdate { get; set; }

        public long? LastUpdateBy { get; set; }

        public short ModifiedNum { get; set; }

        /// <summary>
        ///   地址详情
        /// </summary>
        public string AddressDescription { get; set; }

        /// <summary>
        ///     ContactId
        /// </summary>
        public long? ContactId { get; set; }

        /// <summary>
        /// GeographyId
        /// </summary>
        public long? GeographyId { get; set; }
    }
}
