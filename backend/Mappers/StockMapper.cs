using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.DTOs.Stock;
using backend.Models;

namespace backend.Mappers
{
    public static class StockMapper
    {
        //map an instance of the Stock model to a StockDto (Data Transfer Object).
        public static StockDto toStockDto (this Stock stockModel) 
        {
            return new StockDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase,
                LastDiv = stockModel.LastDiv,
                Industry = stockModel.Industry,
                MarketCap = stockModel.MarketCap
            };
        }

        public static Stock toStockFromDto(this CreateStockRequestDto requestData){
            return new Stock
            {
                Symbol = requestData.Symbol,
                CompanyName = requestData.CompanyName,
                Purchase = requestData.Purchase,
                LastDiv = requestData.LastDiv,
                Industry = requestData.Industry,
                MarketCap = requestData.MarketCap
            };
        }
    }
}